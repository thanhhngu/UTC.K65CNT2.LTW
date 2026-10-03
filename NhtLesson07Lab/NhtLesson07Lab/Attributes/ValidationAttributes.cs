using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

public class ValidationAttributes : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var imagePath = value as string;
        if (string.IsNullOrEmpty(imagePath))
        {
            return new ValidationResult("Image là bắt buộc");
        }

        var env = (IWebHostEnvironment)validationContext.GetService(typeof(IWebHostEnvironment));
        var fullPath = Path.Combine(env.WebRootPath, "products", imagePath);

        if (!File.Exists(fullPath))
        {
            return new ValidationResult("Ảnh phải được upload vào thư mục wwwroot/products");
        }

        return ValidationResult.Success;
    }


}

public class SensitiveWordValidationAttribute : ValidationAttribute
{
    private readonly string[] _bannedWords = { "die", "admin", "dack" };

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var text = value as string;
        if (string.IsNullOrEmpty(text))
            return ValidationResult.Success;

        foreach (var word in _bannedWords)
        {
            if (text.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                return new ValidationResult($"Thuộc tính không được chứa từ khóa nhạy cảm: {word}");
            }
        }

        return ValidationResult.Success;
    }
}

public class MinPriceValidationAttribute : ValidationAttribute
{
    private readonly int _minPrice;

    public MinPriceValidationAttribute(int minPrice)
    {
        _minPrice = minPrice;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var text = value as string;
        if (string.IsNullOrEmpty(text))
        {
            return new ValidationResult("Price là bắt buộc");
        }

        if (!int.TryParse(text, out int price))
        {
            return new ValidationResult("Price phải là số");
        }

        if (price < _minPrice)
        {
            return new ValidationResult($"Price phải >= {_minPrice}");
        }

        return ValidationResult.Success;
    }
}