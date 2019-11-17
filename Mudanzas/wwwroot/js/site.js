﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var app = new Vue({
    el: '#app',
    data: {
        message: 'Hello Vue!',
        saco:'Nothing',
        error: true
    },
    methods: {
        holis: function (event) {
            console.log("hola");
            axios
                .get('https://pokeapi.co/api/v2/pokemon/')
                .then(response => (this.saco = response));
            this.error = false;
        }
    }
})

