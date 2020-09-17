async function guardar() {
  var txtNombre = document.getElementById("txtNombre");
  var txtEspecificaciones = document.getElementById("txtEspecificaciones");
  var imgMoto = document.getElementById("imgMoto");
  var imagen = await toBase64(imgMoto.files[0]);

  var moto = {
    nombre: txtNombre.value,
    especificaciones: txtEspecificaciones.value,
    rutaImagen: imagen
  };

  GuardarEnBaseDeDatos(moto);
  alert("Se ha guardado la moto con éxito");
}

function GuardarEnBaseDeDatos(moto) {
  var listaMotos = localStorage.getItem("ListaMotos");
  listaMotos.push(moto);
  localStorage.setItem("ListaMotos", listaMotos);
}

const toBase64 = file =>
  new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = error => reject(error);
  });
