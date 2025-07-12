using DummyReactBack.Models.ComputingParts;

namespace DummyReactBack.Models;

public class ComputingDevice
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int CpuId { get; set; }
    public CPU Cpu { get; set; }
    public int CameraId { get; set; }
    public Camera Camera { get; set; }
        
}