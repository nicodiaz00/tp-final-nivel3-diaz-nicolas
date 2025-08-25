function abrirModal() {
    console.trace("abrirModal se ejecutó");
    document.getElementById("modalId").style.display = "flex";
}

function cerrarModal() {
    
    document.getElementById("modalId").style.display = "none";
}
/*
const carrusel = document.querySelector(".carrusel");
const slides = document.querySelectorAll(".slide");
const prevBtn = document.querySelector(".prev");
const nextBtn = document.querySelector(".next");

let index = 0;
const totalSlides = slides.length;
let autoSlide;

// ----- Función para actualizar el carrusel -----
function mostrarSlide(n) {
    if (n < 0) {
        index = totalSlides - 1;
    } else if (n >= totalSlides) {
        index = 0;
    } else {
        index = n;
    }
    carrusel.style.transform = `translateX(${-index * 100}%)`;
}

// ----- Botones manuales -----
prevBtn.addEventListener("click", () => {
    mostrarSlide(index - 1);
    reiniciarAutoSlide();
});

nextBtn.addEventListener("click", () => {
    mostrarSlide(index + 1);
    reiniciarAutoSlide();
});

// ----- Auto deslizamiento cada 3s -----
function iniciarAutoSlide() {
    autoSlide = setInterval(() => {
        mostrarSlide(index + 1);
    }, 3000);
}

// Reinicia el temporizador al hacer clic
function reiniciarAutoSlide() {
    clearInterval(autoSlide);
    iniciarAutoSlide();
}
*/
const divMenu = document.createElement("div");
const burgerButton = document.getElementById("burger");

const opcionesMenu = [
     {
        nombre: "Listado",
        direccion: "Listado.aspx"
    },
    {
        nombre: "Listado",
        direccion: "Listado.aspx"
    },
    {
        nombre: "Nuevo Articulo",
        direccion: "Formulario.aspx"
    }

];
function createMenumobile(opciones) {
    
    const ul = document.createElement("ul");
    const menuContent = document.createElement("div");
    menuContent.classList.add("menu-mobile-content");

    for (let i = 0; i < opciones.length; i++) {
        const li = document.createElement("li");
        const a = document.createElement("a");
        a.href = opciones[i].direccion;
        a.textContent = opciones[i].nombre;

        li.appendChild(a);
        ul.appendChild(li)

    }
    menuContent.appendChild(ul);
    return menuContent;
}

function createMenu() {
    menuItems.innerHTML = ""; // Limpiar antes de crear
    opcionesMenu.forEach(opcion => {
        const li = document.createElement("li");
        const a = document.createElement("a");
        a.href = opcion.direccion;
        a.textContent = opcion.nombre;
        li.appendChild(a);
        menuItems.appendChild(li);
    });
}


burgerButton.addEventListener("click", () => {

    createMenu();
    menuOverlay.style.display = "block";
    document.body.style.overflow = "hidden"; // Evita scroll en background
})
closeMenu.addEventListener("click", () => {
    menuOverlay.style.display = "none";
    document.body.style.overflow = "auto";
});

// Cerrar haciendo clic fuera del contenido
menuOverlay.addEventListener("click", e => {
    if (e.target === menuOverlay) {
        menuOverlay.style.display = "none";
        document.body.style.overflow = "auto";
    }
});



/*iniciarAutoSlide();*/


/*
<div class="menu-mobile-1">
                        <ul>
                            <li>
                                <a href="Articulo.aspx">Articulos</a>
                            </li>
                            <li>
                                <a href="Listado.aspx">Listado</a>
                            </li>
                            <li>
                                <a href="#">Mi cuenta</a>
                            </li>
                            
                        </ul>
                    </div>
                    <div class="menu-mobile-2">
                        <ul>
                            <li>
                                <a href="#">Log in</a>
                            </li>
                            <li>
                                <a href="#">Sign up</a>
                            </li>
                        </ul>
                    </div>
                    */

