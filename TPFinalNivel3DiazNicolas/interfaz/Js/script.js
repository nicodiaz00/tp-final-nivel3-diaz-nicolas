
function crearMenuEscritorio(opciones) {
    ulList = document.createElement("ul");
    
    ulList.classList.add("estilo-ul-menu");
    ulList.innerHTML = "";

    opciones.forEach(opcion => {
        const li = document.createElement("li");
        li.classList.add("li-menu-escritorio")
        const a = document.createElement("a");
        a.href = opcion.direccion;
        a.textContent = opcion.nombre;
        li.appendChild(a)
        ulList.appendChild(li);

    });
    return ulList;
}
function crearContenedor() {
    const div = document.createElement("div");

    div.classList.add("btn-menu-burger");
 
    div.id = "burger";
 
    const icono = document.createTextNode("☰");
  
    div.appendChild(icono);

    div.addEventListener("click", () => {
        console.log("hicisteclick");
        createMenu(opcionesMenu);
        menuOverlay.style.display = "block";
        document.body.style.overflow = "hidden";
    });

    const closeMenu = document.getElementById("closeMenu");
    if (closeMenu) {
        closeMenu.addEventListener("click", () => {
            menuOverlay.style.display = "none";
            document.body.style.overflow = "auto";
        });
    }

    menuOverlay.addEventListener("click", e => {
        if (e.target === menuOverlay) {
            menuOverlay.style.display = "none";
            document.body.style.overflow = "auto";
        }
    });

    return div;

}
function createMenu(opciones) {
    
    console.log("createMenu se ejecutó");
    menuItems.innerHTML = ""; // Limpiar antes de crear
    opciones.forEach(opcion => {
        const li = document.createElement("li");
        li.classList.add("li-menu-mobile")
        const a = document.createElement("a");
        a.href = opcion.direccion;
        a.textContent = opcion.nombre;
        li.appendChild(a);
        menuItems.appendChild(li);
    });
}
function actualizarMenu() {
    const menuHeader = document.querySelector(".menu-mobile");
    menuHeader.innerHTML = "";
    // Evitar agregar varias veces el contenedor

    if (window.innerWidth > 700) {
        menuHeader.appendChild(crearMenuEscritorio(opcionesMenu));
    } else {
        menuHeader.appendChild(crearContenedor());
    }

}
function validarNumerosYPuntos(e) {
    const key = e.key;
    if (!(/[0-9]/.test(key) || key === '.')) {
        e.preventDefault();
    }
    if (key === '.' && this.value.includes('.')) {
        e.preventDefault();
    }
}

function validarLetrasYNumeros(e) {
    const key = e.key;
    if (!(/[a-zA-Z0-9]/.test(key))) {
        e.preventDefault();
    }
}

const ddlCampo = document.getElementById('<%= ddlCampo.ClientID %>');
const txtBusqueda = document.getElementById('<%= txtFiltro.ClientID %>');

const aplicarValidacion = function () {
    const valorSeleccionado = ddlCampo.options[ddlCampo.selectedIndex].text;
    txtBusqueda.removeEventListener('keypress', validarNumerosYPuntos);
    txtBusqueda.removeEventListener('keypress', validarLetrasYNumeros);

    if (valorSeleccionado === 'Precio') {
        txtBusqueda.addEventListener('keypress', validarNumerosYPuntos);
    } else {
        txtBusqueda.addEventListener('keypress', validarLetrasYNumeros);
    }
};

document.addEventListener("DOMContentLoaded", actualizarMenu);
window.addEventListener("resize", actualizarMenu);
/*
window.onload = aplicarValidacion;
ddlCampo.addEventListener('change', aplicarValidacion);*/
