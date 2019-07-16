// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let hero = {}

$("#alliance").on("click",
    function () {
        hero.HeroFaction = "Alliance";
    },
);

$("#alliance").click(function () {
    $.ajax({
        type: "POST",
        url: "/Hero/Faction",
        data: JSON.stringify({
            HeroFaction: 1,
            HeroRace: 1,
            HeroClass: 1
        }),
        success: "success",
        dataType: "json",
        contentType: "application/Json"
    })
})