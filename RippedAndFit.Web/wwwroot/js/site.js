const menu = document.querySelector('.nav-bar');
const menuBtn = document.querySelector('.menu-open');
const closeBtn = document.querySelector('.menu-close');

if (menuBtn) {
    menuBtn.addEventListener('click', () => {
        menu.classList.add('open');
    });
}

if (closeBtn) {
    closeBtn.addEventListener('click', () => {
        menu.classList.remove('open');
    });
}

function confirmDelete(url) {
    if (confirm('Are you sure you want to delete this member?')) {
        window.location.href = url;
    }
}

function confirmLogout(logoutUrl) {
    if (confirm("Are you sure you want to log out?")) {
        window.location.href = logoutUrl;
    }
}