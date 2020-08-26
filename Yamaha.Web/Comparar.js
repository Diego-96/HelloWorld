
function CambiarImagen()
{
    var imagenDinamica = document.getElementById("imagenDinamica");
    var listadoMotos = document.getElementById('lista');
    var motoSeleccionada = listadoMotos.value;
    
    if(motoSeleccionada == 1)
    {
        imagenDinamica.src = "./img/cabecera_ninja_zx10r_2011.jpg";
    }
    else if(motoSeleccionada == 2)
    {
        imagenDinamica.src = "./img/HondaCBR1000RR.jpg";
    }
    else if(motoSeleccionada == 3)
    {
        imagenDinamica.src = "./img/ktm-super-duke-r-2017.jpg";
    }
    else
    {
        imagenDinamica.src = "https://us.123rf.com/450wm/urfandadashov/urfandadashov1809/urfandadashov180901275/109135379-foto-no-disponible-icono-del-vector-aislado-en-la-ilustraci%C3%B3n-transparente-transparente-concepto-de-esp.jpg?ver=6";
    }
    Saludar('Diego');
}

function Saludar(nombre)
{
    alert('hola ' + nombre);
}
