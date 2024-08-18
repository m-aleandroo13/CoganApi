namespace CoganApi.Dtos
{
    public class ItemsDto
    {
        public string Name { get; set; }
        public double? Stock { get; set; }
        public string UnitOfMeasure { get; set; }
        public string? Shape { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public string? WidthMeasure { get; set; }
        public string? LengthMeasure { get; set; }
        public string? HeightMeasure { get; set; }
    }
}
