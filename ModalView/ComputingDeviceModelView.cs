using System.ComponentModel.DataAnnotations;
using DummyReactBack.Models;
using DummyReactBack.Models.ComputingParts;

namespace DummyReactBack.ModalView;

public class ComputingDeviceModelView
{
    [Required]
    public Product Product { get; set; }
    [Required]
    public CPU CPU { get; set; }
    [Required]
    public Camera Camera { get; set; }
}