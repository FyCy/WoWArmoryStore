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



let faction = "";
let factionClasses = "";
let heroClass = "";
let heroName = "";


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
})
//Classes
//----------------------------Horde----------------------------

$(".hordeRaces").click(function () {
    if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Pandaren";
    }
})
$(".hordeRaces").click(function () {
    if ($(this).val() === "BloodElf") {
        $(".bloodElfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "BloodElf";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Orc") {
        $(".orcClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Orc";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Undead") {
        $(".undeadClassses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Undaed";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Tauren") {
        $(".taurenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Tauren";
    }
})
$(".hordeRaces").click(function () {
    if ($(this).val() === "Troll") {
        $(".trollClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Troll";
    }
})

$(".hordeRaces").click(function () {
    if ($(this).val() === "Goblin") {
        $(".goblinClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Goblin";
    }
})
//----------------------------Alliance----------------------------
$(".allianceRaces").click(function () {
    if ($(this).val() === "Human") {
        $(".humanClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Human";
    }
})

$(".allianceRaces").click(function () {
    if ($(this).val() === "Pandaren") {
        $(".pandarenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Pandaren";
    }
})

$(".allianceRaces").click(function () {
    if ($(this).val() === "Dwarf") {
        $(".dwarfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Dwarf";
    }
})

$(".allianceRaces").click(function () {
    if ($(this).val() === "NightElf") {
        $(".nightElfClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "NightElf";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Gnome") {
        $(".gnomeClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Gnome";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Draenei") {
        $(".draeneiClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Draenei";
    }
})
$(".allianceRaces").click(function () {
    if ($(this).val() === "Worgen") {
        $(".worgenClasses").show();
        $(".allianceRaces").hide();
        $(".hordeRaces").hide();
        factionClasses = "Worgen";
    }
})
//Factions
$(".faction").click(function () {
    if ($(this).val() === "Horde") {
        $(".hordeRaces").show();
        $(".allianceRaces").hide();
        $(".faction").hide();
        this.faction = $(this).val();
    }
    if ($(this).val() === "Alliance") {
        $(".allianceRaces").show();
        $(".hordeRaces").hide();
        $(".faction").hide();
        faction = $(this).val();
        console.log($(this).val());
        console.log(faction);
        debugger;
    }
});


$("#kur").click(function () {
    $.ajax({
        url: "/Hero/Faction",
        type: "POST",
        data:JSON.stringify({
            HeroName: heroName,
            HeroFaction: "Horde",
            HeroRace: "Pandaren",
            HeroClass: Paladin
        }),
        success: "success",
        dataType: "json",
        contentType: "application/json"
    })
});
console.log(faction);
console.log(heroClass);
console.log(factionClasses);

debugger;