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
$(".heroName").hide();

function hiding() {
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
    $(".heroName").hide();
}

let faction = "";
let factionClasses = "";
let heroClass = "";
let heroName = "";
let chosenRaces = "";


$(".LastStep").click(function () {
    $(".heroName").show();
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
    heroClass = $(this).val();
});
//Classes
//----------------------------Horde----------------------------

$(".hordeRaces").click(function () {
    if ($(this).val() === "Orc") {
        $(".orcClasses").show();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
        $(".allianceRaces").hide();
    } else if ($(this).val() === "Undead") {
        $(".undeadClassses").show();
        $(".allianceRaces").hide();
        $(".pandarenClasses").hide();
        $(".orcClasses").hide();
        $(".taurenClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    }
    else if ($(this).val() === "BloodElf") {
        $(".bloodElfClasses").show();
        $(".allianceRaces").hide();
        $(".pandarenClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".trollClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Tauren") {
        $(".taurenClasses").show();
        $(".allianceRaces").hide();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".trollClasses").hide();
        $(".goblinClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Troll") {
        $(".trollClasses").show();
        $(".allianceRaces").hide();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Goblin") {
        $(".goblinClasses").show();
        $(".allianceRaces").hide();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".trollClasses").hide();
        $(".dwarfClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    }
    factionClasses = $(this).val();
});
//----------------------------Alliance----------------------------
$(".allianceRaces").click(function () {
    if ($(this).val() === "Human") {
        $(".humanClasses").show();
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
        $(".heroName").hide();
    } else if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".hordeRaces").hide();
        $(".humanClasses").hide();
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
        $(".heroName").hide();
    } else if ($(this).val() === "Dwarf") {
        $(".dwarfClasses").show();
        $(".hordeRaces").hide();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".trollClasses").hide();
        $(".goblinClasses").hide();
        $(".humanClasses").hide();
        $(".nightElfClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "NightElf") {
        $(".nightElfClasses").show();
        $(".hordeRaces").hide();
        $(".pandarenClasses").hide();
        $(".bloodElfClasses").hide();
        $(".orcClasses").hide();
        $(".undeadClassses").hide();
        $(".taurenClasses").hide();
        $(".trollClasses").hide();
        $(".goblinClasses").hide();
        $(".dwarfClasses").hide();
        $(".humanClasses").hide();
        $(".gnomeClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Gnome") {
        $(".gnomeClasses").show();
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
        $(".humanClasses").hide();
        $(".draeneiClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Draenei") {
        $(".draeneiClasses").show();
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
        $(".humanClasses").hide();
        $(".worgenClasses").hide();
        $(".heroName").hide();
    } else if ($(this).val() === "Worgen") {
        $(".worgenClasses").show();
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
        $(".humanClasses").hide();
        $(".heroName").hide();
    }
    chosenRaces = $(this).val();
    $.ajax({
        url: "/Hero/Faction",
        data: {
            classType: chosenRaces
        },
        method: "GET",
    })
    factionClasses = $(this).val();
});
//Factions // NAPRAVI GO NA FINKICI[ BE!!!!]

$(".faction").click(function () {
    if ($(this).val() === "Horde") {
        $(".hordeRaces").show();
        $(".allianceRaces").hide();
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
        $(".heroName").hide();
        faction = $(this).val();
    } else if ($(this).val() === "Alliance") {
        $(".allianceRaces").show();
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
        $(".heroName").hide();
        faction = $(this).val();
    }
    $(".heroName").hide();
});

//$(".chosenRace").click(function () {
//    chosenRaces = $(".chosenRace").val();
//    $ajax({
//        url: "/Hero/HeroCreation",
//        data: {
//            chosenRace
//        },
//        method: "GET",

//    })
//})


$("#kur").click(function () {
    heroName = $(".heroName").val();
    $.ajax({
        url: "/Hero/HeroCreation",
        data: {
            HeroName: heroName,
            HeroFaction: faction,
            HeroClass: heroClass,
            HeroRace: factionClasses
        },
        method: "POST",
        success: "success",
        //dataType: "json",
        //contentType: "application/json",
    })
})
