using System.ComponentModel.DataAnnotations;

namespace ViolationsCollecting.Presenter
{
	public class Validation<T>
	{
        public bool IsValid { get; set; }
        public List<ValidationResult> GetValidationResult(T obj)
		{
			var context = new ValidationContext(obj, serviceProvider: null, items: null);

			var validationResults = new List<ValidationResult>();
			
			IsValid = Validator.TryValidateObject(obj, context, validationResults, true);

			if (!IsValid)
			{
				return validationResults;
			}

			return new List<ValidationResult>();
		}
	}
}
