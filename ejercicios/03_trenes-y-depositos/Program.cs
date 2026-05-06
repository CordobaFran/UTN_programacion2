using clases.Formacion;
using clases.Locomotora;
using clases.Vagones;
using clases.VagonPasajeros;

VagonPasajeros vagonPasajeros01 = new VagonPasajeros(20, 3);
VagonPasajeros vagonPasajeros02 = new VagonPasajeros(20, 3);
VagonPasajeros vagonPasajeros03 = new VagonPasajeros(20, 3);
VagonPasajeros vagonPasajeros04 = new VagonPasajeros(20, 3);
VagonPasajeros vagonPasajeros05 = new VagonPasajeros(15, 2);

Locomotora locomotora01 = new Locomotora(1000, 12000, 80);

Formacion formacion01 = new Formacion();

formacion01?.Vagones?.Add(vagonPasajeros01);
formacion01?.Vagones?.Add(vagonPasajeros02);
formacion01?.Vagones?.Add(vagonPasajeros03);
formacion01?.Vagones?.Add(vagonPasajeros04);
formacion01?.Vagones?.Add(vagonPasajeros05);
formacion01?.AgregarLocomotora(locomotora01);

foreach (VagonPasajeros vagon in formacion01.Vagones)
{
    System.Console.WriteLine(vagon.CantPasajeros);
    System.Console.WriteLine();
}
