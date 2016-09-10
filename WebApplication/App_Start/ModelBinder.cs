using System;
using System.Web.Mvc;
using System.Globalization;

namespace HRM.Webpages
{
    public class DateModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
            ModelState modelState = new ModelState { Value = valueResult };
            object actualValue = null;
            try
            {
                string attemptedValue = valueResult.AttemptedValue;
                if (String.IsNullOrEmpty(attemptedValue)) return null;
                attemptedValue = attemptedValue.Replace(" tháng ", "/").Replace(" năm ", "/");
                actualValue = Convert.ToDateTime(attemptedValue, CultureInfo.CurrentCulture);
            }
            catch (FormatException e)
            {
                modelState.Errors.Add(e);
            }
            finally
            {
                bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
            }
            return actualValue;
        }
    }
}