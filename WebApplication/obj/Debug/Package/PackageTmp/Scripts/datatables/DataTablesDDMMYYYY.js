var DDMMYYYToOrd = function (date) {
    var date = date.replace(" ", "");
    if (date.indexOf('.') > 0) {
        /*date a, format dd.mn.(yyyy) ; (year is optional)*/
        var vn_date = date.split('.');
    } else {
        /*date a, format dd/mn/(yyyy) ; (year is optional)*/
        var vn_date = date.split('/');
    }
    if (vn_date.length < 2)
        return "";
    /*year (optional)*/
    if (vn_date[2]) {
        var year = vn_date[2];
    } else {
        var year = 0;
    }
    /*month*/
    var month = vn_date[1];
    if (month.length == 1) {
        month = 0 + month;
    }
    /*day*/
    var day = vn_date[0];
    if (day.length == 1) {
        day = 0 + day;
    }
    return (year + month + day) * 1;
};

jQuery.extend(jQuery.fn.dataTableExt.oSort, {
    "date-vn": function (date) {
        return DDMMYYYToOrd(date);
    },

    "date-vn-asc": function (a, b) {
        a = DDMMYYYToOrd(a);
        b = DDMMYYYToOrd(b);
        return ((a < b) ? -1 : ((a > b) ? 1 : 0));
    },

    "date-vn-desc": function (a, b) {
        a = DDMMYYYToOrd(a);
        b = DDMMYYYToOrd(b);
        return ((a < b) ? 1 : ((a > b) ? -1 : 0));
    }
});