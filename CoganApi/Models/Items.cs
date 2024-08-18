namespace CoganApi.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Stock { get; set; }
        public string Unit_Of_Measure { get; set; }
        public string? Shape { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public string? Width_Measure { get; set; }
        public string? Length_Measure { get; set; }
        public string? Height_Measure { get; set; }
        public double? Rop { get; set; } 
        public double? Safety_Stock { get; set; } 
        public double? Eoq { get; set; }
    }
}
