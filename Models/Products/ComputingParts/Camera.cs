namespace DummyReactBack.Models.ComputingParts;

public class Camera
{
    public int Id { get; set; }
    public float Megapixels { get; set; }
    public int Framerate { get; set; }
    public required string VideoResolution { get; set; }
    public required int BrandId  { get; set; }
    public required string Model { get; set; }
    
    public ICollection<ComputingDevice> ComputingDevices { get; } =  new List<ComputingDevice>();
}