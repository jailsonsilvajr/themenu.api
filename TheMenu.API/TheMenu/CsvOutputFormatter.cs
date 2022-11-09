using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;
using System.Text;
using TheMenu.Domain.DTOs;

namespace TheMenu
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }

        protected override bool CanWriteType(Type? type)
        {
            if (typeof(CategoryDTO).IsAssignableFrom(type) || typeof(IEnumerable<CategoryDTO>).IsAssignableFrom(type))
            {
                return base.CanWriteType(type);
            }

            return false;
        }

        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            var response = context.HttpContext.Response;
            var buffer = new StringBuilder();

            if (context.Object is IEnumerable<CategoryDTO>)
            {
                foreach (var categoryDTO in (IEnumerable<CategoryDTO>)context.Object)
                {
                    FormatCsv(buffer, categoryDTO);
                }
            }
            else
            {
                FormatCsv(buffer, (CategoryDTO)context.Object);
            }

            await response.WriteAsync(buffer.ToString());
        }

        private static void FormatCsv(StringBuilder buffer, CategoryDTO category)
        {
            buffer.AppendLine($"{category.Id},\"{category.Name}\"");
        }
    }
}
