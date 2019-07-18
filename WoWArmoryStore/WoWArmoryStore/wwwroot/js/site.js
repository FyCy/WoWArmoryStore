// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".allianceRaces").hide();
$(".hordeRaces").hide();
$(".pandarenClasses").hide();
$()
let faction = "";
let heroClass = "";

$(".allianceRaces").click(function () {
    if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Pandaren";
    }
})

$(".faction").click(function () {
    if ($(this).val() === "Horde") {
        $(".hordeRaces").show();
        $(".allianceRaces").hide();
        $(".faction").hide();
        faction = "Horde";
    }
    if ($(this).val() === "Alliance") {
        $(".allianceRaces").show();
        $(".hordeRaces").hide();
        $(".faction").hide();
        faction = "Alliance";
    }
});
$("#kur").click(function () {
    $.ajax({
        type: "POST",
        url: "/Hero/Faction",
        data: JSON.stringify({
            HeroName: "Strashimir",
            HeroFaction: "Alliance",
            HeroRace: "Goblin",
            HeroClass: "Druid"
        }),
        success: "success",
        dataType: "json",
        contentType: "application/json"
    })
})