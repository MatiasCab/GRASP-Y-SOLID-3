
namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        void PrintRecipe(Recipe recipe);
    }
}

/* Se utilizo el patron de Polymorfism. Se definio un tipo IPrinter y dos clases mas que implementas este tipo,
ya que en la version anterior la unica clase que se encargaba de imprimir las recetas, preguntaba cual era del destino,
y esto es justamente lo que el patron Polymorfism dice que no hay que hacer. Por lo que cada clase del tipo IPrinter,
tiene la responsabilidad de imprimir la receta en un destino diferente. Convirtiendo a la operacion "PrintRecipe" en polimorfica.*/

/* Asimsimo, ademas de que el metodo PrintRecipe es polimorfico, el mismo tambien cumplo con el principio solid de LSV,
ya que el metodo no cambia nungun aspecto de lo propio a imprimir, sino que lo que hace es imprimir la receta
en ubicaciones diferentes, dependiendo de la clase que se use*/