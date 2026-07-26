// AdminLTE and Blazor Integration Helper
(function () {
    'use strict';

    // Initialize AdminLTE features after Blazor renders
    window.AdminLTEBlazor = {
        initialize: function () {
            // Initialize AdminLTE
            if (typeof AdminLTE !== 'undefined' && AdminLTE.layout) {
                AdminLTE.layout.fix();
            }

            // Initialize tooltips
            const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
            tooltipTriggerList.map(function (tooltipTriggerEl) {
                return new bootstrap.Tooltip(tooltipTriggerEl);
            });

            // Initialize popovers
            const popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
            popoverTriggerList.map(function (popoverTriggerEl) {
                return new bootstrap.Popover(popoverTriggerEl);
            });

            // Initialize treeview
            if ($.fn.treeview) {
                $('[data-widget="treeview"]').treeview({
                    animated: true,
                    namespace: 'treeview',
                    trigger: '.nav-link'
                });
            }

            console.log('AdminLTE Blazor initialized');
        },

        showErrorMessage: function (message) {
            const errorUI = document.getElementById('blazor-error-ui');
            if (errorUI) {
                errorUI.style.display = 'block';
                errorUI.classList.add('show');
            }
        },

        hideErrorMessage: function () {
            const errorUI = document.getElementById('blazor-error-ui');
            if (errorUI) {
                errorUI.style.display = 'none';
                errorUI.classList.remove('show');
            }
        },

        toggleSidebar: function () {
            const sidebar = document.querySelector('.main-sidebar');
            if (sidebar) {
                sidebar.classList.toggle('show');
            }
        },

        setTheme: function (theme) {
            const body = document.querySelector('body');
            if (body) {
                body.classList.remove('light-mode', 'dark-mode');
                body.classList.add(theme + '-mode');
                localStorage.setItem('adminlte-theme', theme);
            }
        },

        getTheme: function () {
            return localStorage.getItem('adminlte-theme') || 'light';
        }
    };

    // Auto-initialize on page load and after Blazor updates
    if (document.readyState === 'loading') {
        document.addEventListener('DOMContentLoaded', function () {
            window.AdminLTEBlazor.initialize();
        });
    } else {
        window.AdminLTEBlazor.initialize();
    }

    // Reinitialize after Blazor component updates
    if (window.Blazor) {
        Blazor.addEventListener('pageTitle', function (event) {
            window.AdminLTEBlazor.initialize();
        });
    }
})();
