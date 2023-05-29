namespace BuberBreakfast.ServiceErrors;
using BuberBreakfast.Models;
using ErrorOr;

public static class Errors
{
    public static class Breakfast
    {
        public static Error InvalidName => Error.Validation(
            code: "Breakfast.InvalidName",
            description: $"Breakfast name must be at least {Models.Breakfast.MinNameLength}" +
                $" characters long and at most {Models.Breakfast.MaxNameLength} charactes long.");
        
        public static Error InvalidDescription => Error.Validation(
            code: "Breakfast.InvalidDescription",
            description: $"Breakfast description must be at least {Models.Breakfast.MinDescriptionLength}" +
                $" characters long and at most {Models.Breakfast.MaxDescriptionLength} charactes long.");
        

        public static Error NotFound => Error.NotFound(
            code: "Breakfast.NotFound",
            description: "Breakfast not found");
        
    }
}