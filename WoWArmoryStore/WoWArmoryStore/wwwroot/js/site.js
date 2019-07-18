// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".alianceRaces").hide();
$(".hordeRaces").hide();
$()
let faction = "";

$(".faction").click(function () {
    if ($(this).val() === "Horde") {
        $(".hordeRaces").show();
        $(".alianceRaces").hide();
        $(".faction").hide();
        faction = "Horde";
    }
    if ($(this).val() === "Alliance") {
        $(".alianceRaces").show();
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