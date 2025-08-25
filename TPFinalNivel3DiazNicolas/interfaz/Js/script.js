
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
/*
document.addEventListener("DOMContentLoaded", function () {
    const menuItems = document.getElementById("menuItems");
    const menuHeader = document.querySelector(".menu-mobile");
    const burgerButton = document.querySelector(".btn-menu-burger");
    const menuOverlay = document.getElementById("menuOverlay");

    // ⚡ Generar menú dinámicamente desde opcionesMenu (pasado desde el code-behind)
    if (typeof opcionesMenu !== "undefined" && Array.isArray(opcionesMenu)) {
        opcionesMenu.forEach(opcion => {
            const li = document.createElement("li");
            const a = document.createElement("a");
            a.href = opcion.direccion;
            a.textContent = opcion.nombre;
            li.appendChild(a);
            menuItems.appendChild(li);
        });
    } else {
        console.error("No se encontraron opciones para el menú");
    }

    // ⚡ Evento para abrir el menú móvil
    console.log(burgerButton)
    if (burgerButton) {
        burgerButton.addEventListener("click", () => {
            console.log("hicisteclick");
            createMenu(opcionesMenu);
            menuOverlay.style.display = "block";
            document.body.style.overflow = "hidden"; // Bloquear scroll
        });
    } else {
        console.error("No se encontró el botón burger");
    }

    // ⚡ Evento para cerrar el menú al hacer click en la X
    const closeMenu = document.getElementById("closeMenu");
    if (closeMenu) {
        closeMenu.addEventListener("click", () => {
            menuOverlay.style.display = "none";
            document.body.style.overflow = "auto";
        });
    }

    // ⚡ Cerrar el menú al hacer clic fuera del contenido
    menuOverlay.addEventListener("click", e => {
        if (e.target === menuOverlay) {
            menuOverlay.style.display = "none";
            document.body.style.overflow = "auto";
        }
    });

    // ⚡ Ajustar el menú según el tamaño de la ventana
    function actualizarMenu() {
        menuHeader.innerHTML = ""; // Limpiamos antes de agregar
        if (window.innerWidth > 700) {
            menuHeader.appendChild(crearMenuEscritorio(opcionesMenu));
        } else {
            menuHeader.appendChild(crearContenedor());
        }
    }

    // Inicializamos y escuchamos cambios de tamaño
    actualizarMenu();
    window.addEventListener("resize", actualizarMenu);
});
*/

document.addEventListener("DOMContentLoaded", actualizarMenu);
window.addEventListener("resize", actualizarMenu);