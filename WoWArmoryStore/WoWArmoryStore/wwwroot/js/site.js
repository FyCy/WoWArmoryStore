// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(".allianceRaces").hide();
$(".hordeRaces").hide();
$(".pandarenClasses").hide();
$(".bloodElfClasses").hide();
$(".orcClasses").hide();
$(".undeadClassses").hide();
$(".taurenClasses").hide();
$(".trollClasses").hide();
$(".goblinClasses").hide();
$(".dwarfClasses").hide();
$(".nightElfClasses").hide();
$(".gnomeClasses").hide();
$(".draeneiClasses").hide();
$(".worgenClasses").hide();
$(".humanClasses").hide();



let faction = "";
let heroClass = "";

//Classes
//----------------------------Horde----------------------------
$(".allianceRaces").click(function () {
    if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Pandaren";
    }
})
$(".hordeRaces").click(function () {
    if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Pandaren";
    }
})
$(".hordeRaces").click(function () {
    if ($(this).val() === "BloodElf") {
        $(".bloodElfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "BloodElf";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Orc") {
        $(".orcClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Orc";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Undead") {
        $(".undeadClassses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Tauren") {
        $(".taurenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
$(".hordeRaces").click(function () {
    if ($(this).val() === "Troll") {
        $(".trollClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Goblin") {
        $(".goblinClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
//----------------------------Alliance----------------------------
$(".allianceRaces").click(function () {
    if ($(this).val() === "Human") {
        $(".humanClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})

$(".allianceRaces").click(function () {
    if ($(this).val() === "Dwarf") {
        $(".dwarfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})

$(".allianceRaces").click(function () {
    if ($(this).val() === "NightElf") {
        $(".nightElfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Gnome") {
        $(".gnomeClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Draenei") {
        $(".draeneiClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Worgen") {
        $(".worgenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        heroClass = "Undaed";
    }
})
//Factions
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