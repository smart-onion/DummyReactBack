namespace DummyReactBack.Models.ComputingParts;

public class CPU
{
    public int Id { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public int CpuCores { get; set; }
    public int GpuCores { get; set; }
    public string Model { get; set; }
    public double Speed { get; set; }
    public ICollection<ComputingDevice> ComputingDevices { get; } =  new List<ComputingDevice>();
}