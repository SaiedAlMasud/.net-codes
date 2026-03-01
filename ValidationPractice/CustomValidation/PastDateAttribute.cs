using System;
using System.ComponentModel.DataAnnotations;
public class PastDateAttribute: ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        // If no value provided, don't consider it invalid here (let [Required] handle nulls)
        if (value == null)
        {
            return ValidationResult.Success;
        }

        // Safely check and unbox the value
        if (value is DateTime inputDate)
        {
            if (inputDate.Date > DateTime.Today)
            {
                return new ValidationResult("The date must be in the past.");
            }

            return ValidationResult.Success;
        }

        // If the value is not a DateTime, treat as invalid input
        return new ValidationResult("Invalid date value.");
    }
}
