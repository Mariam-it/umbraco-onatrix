document.addEventListener('DOMContentLoaded', function() {
    const menuIcon = document.querySelector('.menu-icon i'); // Välj ikon inom .menu-icon
    const navbarContainer = document.querySelector('.header-content .navbar');

    // När hamburgermenynsikon klickas, växla .show-nav klassen och ändra ikon
    menuIcon.addEventListener('click', function() {
        navbarContainer.classList.toggle('show-menu'); // Växlar visning av nav och search-icon

        // Växlar mellan hamburgermenynsikon och stängningsikon
        if (menuIcon.classList.contains('fa-bars')) {
            menuIcon.classList.remove('fa-bars');
            menuIcon.classList.add('fa-x');
        } else {
            menuIcon.classList.remove('fa-x');
            menuIcon.classList.add('fa-bars');
        }
    });

    function checkWindowSize() {
        if (navbarContainer.classList.contains('show-menu') && window.innerWidth >= 992) {
            navbarContainer.classList.remove('show-menu');
            menuIcon.classList.remove('fa-x');
            menuIcon.classList.add('fa-bars');
        }
    }

    // Kör funktionen vid sidladdning och när fönstret ändrar storlek
    window.addEventListener('resize', checkWindowSize);

    // Kör funktionen direkt vid sidladdning
    checkWindowSize();
});
document.addEventListener('DOMContentLoaded', function() {
    const searchIcon = document.querySelector('.main-search');
    const headerSearchIcon = document.querySelector('.header-search');

    // När du klickar på searchIcon
    searchIcon.addEventListener('click', function(event) {
        event.stopPropagation(); // Stoppar händelsen från att bubbla upp till dokumentnivå

        if (searchIcon.style.display === 'none') {
            searchIcon.style.display = 'inline-block'; 
            headerSearchIcon.style.display = 'none';
        } else {
            searchIcon.style.display = 'none';
            headerSearchIcon.style.display = 'inline-block';
        }
    });

    // Klick utanför elementen
    document.addEventListener('click', function(event) {
        // Kontrollera om klicket sker utanför searchIcon och headerSearchIcon
        if (!searchIcon.contains(event.target) && !headerSearchIcon.contains(event.target)) {
            searchIcon.style.display = 'inline-block';
            headerSearchIcon.style.display = 'none';
        }
    });
});
