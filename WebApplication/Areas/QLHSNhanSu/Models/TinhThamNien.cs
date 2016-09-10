using System;
using System.Collections.Generic;

namespace HRM.QLTTNhanSu.Models
{
    public struct ThamNien
    {
        public int SoThang { get; set; }
        public int SoNam { get; set; }
        public int TongThang
        {
            get { return SoNam * 12 + SoThang; }
        }
        public override string ToString()
        {
            return String.Format("{0} năm {1} tháng", SoNam, SoThang);
        }
        public int TongNgay { get; set; }
    }

    public class DateRanges
    {
        class Date
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
            public Date(DateTime date)
            {
                Day = date.Day; Month = date.Month; Year = date.Year;
            }
            private int CompareTo(Date date)
            {
                return this.ToDateTime().CompareTo(date.ToDateTime());
            }
            public static bool operator <(Date d1, Date d2)
            {
                return d1.CompareTo(d2) < 0;
            }
            public static bool operator ==(Date d1, Date d2)
            {
                return d1.CompareTo(d2) == 0;
            }
            public static bool operator >(Date d1, Date d2)
            {
                return d1.CompareTo(d2) > 0;
            }
            public static bool operator !=(Date d1, Date d2)
            {
                return d1.CompareTo(d2) != 0;
            }
            public static bool operator <=(Date d1, Date d2)
            {
                return d1.CompareTo(d2) <= 0;
            }
            public static bool operator >=(Date d1, Date d2)
            {
                return d1.CompareTo(d2) >= 0;
            }
            public DateTime ToDateTime()
            {
                return new DateTime(Year, Month, Day);
            }
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
        class DateRange
        {
            public Date FromDate { get; set; }
            public Date ToDate { get; set; }
            public DateRange(Date fromDate, Date toDate)
            {
                FromDate = fromDate; ToDate = toDate;
            }
            public DateRange(DateTime fromDate, DateTime toDate)
            {
                FromDate = new Date(fromDate); ToDate = new Date(toDate);
            }
        }

        private List<DateRange> Range1 = new List<DateRange>();
        private List<DateRange> Range2 = new List<DateRange>();

        private DateRange Check(Nullable<DateTime> fromDate, Nullable<DateTime> toDate)
        {
            if (!fromDate.HasValue)
                throw new Exception("fromDate is required");
            if (!toDate.HasValue)
            {
                if (fromDate > DateTime.Today)
                    throw new Exception("fromDate > Today");
                return new DateRange(fromDate.Value, DateTime.Today);
            }
            else
            {
                if (fromDate > toDate)
                    throw new Exception("fromDate > toDate");
                return new DateRange(fromDate.Value, toDate.Value);
            }
        }

        public DateRanges() { }

        public DateRanges(Nullable<DateTime> fromDate, Nullable<DateTime> toDate)
        {
            Check(fromDate, toDate);
            if (!toDate.HasValue)
                toDate = DateTime.Today;
            Range1.Add(new DateRange(fromDate.Value, toDate.Value));
        }

        public void Add(Nullable<DateTime> fromDate, Nullable<DateTime> toDate)
        {
            try
            {
                Add(fromDate, toDate, Range1);
            }
            catch (Exception) { }
        }

        private void Add(Nullable<DateTime> fromDate, Nullable<DateTime> toDate, List<DateRange> Range)
        {
            var dates = Check(fromDate, toDate);
            foreach (var range in Range)
            {
                if (range.FromDate <= dates.FromDate && dates.FromDate <= range.ToDate)
                {
                    if (dates.ToDate > range.ToDate)
                        range.ToDate = dates.ToDate;
                    return;
                }
                if (range.FromDate <= dates.ToDate && dates.ToDate <= range.ToDate)
                {
                    if (dates.FromDate < range.FromDate)
                        range.FromDate = dates.FromDate;
                    return;
                }
            }
            Range.Add(new DateRange(dates.FromDate, dates.ToDate));
        }

        public void Sub(Nullable<DateTime> fromDate, Nullable<DateTime> toDate)
        {
            try
            {
                Add(fromDate, toDate, Range2);
            }
            catch (Exception) { }
        }

        private void Union(List<DateRange> Range)
        {
            for (int i = 0; i < Range.Count; i++)
            {
                var range = Range[0];
                Range[0] = Range[i];
                Range[i] = range;
                for (int j = 1; j < Range.Count; j++)
                {
                    if (Range[j].FromDate <= Range[0].FromDate && Range[0].FromDate <= Range[j].ToDate)
                    {
                        if (Range[0].ToDate > Range[j].ToDate)
                            Range[j].ToDate = Range[0].ToDate;
                        Range.RemoveAt(0); i = -1; break;
                    }
                    if (Range[j].FromDate <= Range[0].ToDate && Range[0].ToDate <= Range[j].ToDate)
                    {
                        if (Range[0].FromDate < Range[j].FromDate)
                            Range[j].FromDate = Range[0].FromDate;
                        Range.RemoveAt(0); i = -1; break;
                    }
                }
            }
        }

        public int ToMonths()
        {
            Union(Range1);
            Union(Range2);
            foreach (var range in Range2)
                for (int i = 0; i < Range1.Count; i++)
                {
                    if (Range1[i].FromDate <= range.FromDate && range.FromDate <= Range1[i].ToDate)
                    {
                        if (range.ToDate < Range1[i].ToDate)
                            Range1.Add(new DateRange(range.ToDate, Range1[i].ToDate));
                        Range1[i].ToDate = range.FromDate;
                    }
                    if (Range1[i].FromDate <= range.ToDate && range.ToDate <= Range1[i].ToDate)
                    {
                        if (range.FromDate > Range1[i].FromDate)
                            Range1.Add(new DateRange(Range1[i].FromDate, range.FromDate));
                        Range1[i].FromDate = range.ToDate;
                    }
                    if (range.FromDate <= Range1[i].FromDate && Range1[i].ToDate <= range.ToDate)
                    {
                        Range1.RemoveAt(i); i -= 1;
                    }
                }
            var months = new ThamNien();
            foreach (var range in Range1)
            {
                var value = TinhThamNien.Ti1nh(range.FromDate.ToDateTime(), range.ToDate.ToDateTime());
                months.SoNam += value.SoNam;
                months.SoThang += value.SoThang;
            }
            return months.TongThang;
        }
    }

    public class TinhThamNien
    {
        public static ThamNien Ti1nh(Nullable<DateTime> ngayBatDau, Nullable<DateTime> ngayKetThuc)
        {
            if (!ngayBatDau.HasValue)
                return new ThamNien();
            if (!ngayKetThuc.HasValue)
                return Ti1nh(ngayBatDau.Value, DateTime.Today);
            return Ti1nh(ngayBatDau.Value, ngayKetThuc.Value);
        }

        public static ThamNien Ti1nh(DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            int nam = 0, thang = 0, ngay = 0;
            if (ngayKetThuc <= ngayBatDau) return new ThamNien();
            int hieu = (ngayKetThuc - ngayBatDau).Days;
            while (ngayBatDau <= ngayKetThuc)
            {
                ngayBatDau = ngayBatDau.AddYears(1);
                if (ngayBatDau <= ngayKetThuc) nam++;
            }
            ngayBatDau = ngayBatDau.AddYears(-1);
            while (ngayBatDau <= ngayKetThuc)
            {
                ngayBatDau = ngayBatDau.AddMonths(1);
                if (ngayBatDau <= ngayKetThuc) thang++;
            }
            ngayBatDau = ngayBatDau.AddMonths(-1);
            while (ngayBatDau <= ngayKetThuc)
            {
                ngayBatDau = ngayBatDau.AddDays(1);
                if (ngayBatDau <= ngayKetThuc) ngay++;
            }
            if (ngay >= 15) thang++;
            return new ThamNien() { SoNam = nam, SoThang = thang, TongNgay = hieu };
        }
    }
}
