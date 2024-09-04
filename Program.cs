// See https://aka.ms/new-console-template for more information

using RepartidoCirculo;
using RepartidoCirculo.Ejercicio_2;

/*
Circulo primer = new Circulo(5);
primer.GetPerimetro();
primer.GetArea();*/

Ingredientes frutilla = new Ingredientes("Frutilla", 5);
Ingredientes leche = new Ingredientes("Leche", 5);

Smothie BatidoFrutilla = new Smothie("Batido de Frutilla", 5);
BatidoFrutilla.setAddIngredient(frutilla);
BatidoFrutilla.setAddIngredient(leche);

BatidoFrutilla.getFullSmothie();
Console.WriteLine(BatidoFrutilla.getFullPrice());