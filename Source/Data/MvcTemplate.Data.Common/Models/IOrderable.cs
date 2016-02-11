namespace MvcTemplate.Data.Common.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IOrderable
    {
        [Index]
        int OrderBy { get; set; }
    }
}
