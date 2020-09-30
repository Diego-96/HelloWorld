var motos = [];
function CambiarImagen() {
	var imagenDinamica = document.getElementById("imagenDinamica");
	var listadoMotos = document.getElementById("listaMotos");
	var idMotoSeleccionada = listadoMotos.value;
	var posicion = idMotoSeleccionada - 1;
	imagenDinamica.src = motos[posicion].rutaImagen;
}

function MostrarEspecificaciones() {
	var especificaciones = document.getElementById("especificaciones");
	especificaciones.classList.remove("especificaciones-texto");
}

function agregarMoto() {
	window.location = "./NuevaMoto.html";
}

function ListarMotos() {
	var listaMotos = document.getElementById("listaMotos");
	ConsultarMotos();

	for (var i = 0; i < motos.length; i++) {
		var option = document.createElement("option");
		option.value = i + 1;
		option.innerHTML = motos[i].nombre;
		listaMotos.appendChild(option);
	}
}

function ConsultarMotos() {
	var motosStorage = localStorage.getItem("ListaMotos") || "[]";
	motos = JSON.parse(motosStorage);
}
