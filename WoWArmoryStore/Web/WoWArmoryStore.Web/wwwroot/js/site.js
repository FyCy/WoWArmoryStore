﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let faction = "";
let factionClasses = "";
let heroClass = "";
let heroName = "";
let heroToDeleteName = "";


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
        $(".trollClasses").hide();
        $(".bloodElfClasses").hide();
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
//AJAX REQUESTS

$("#submitButton").click(function () {
    heroName = $(".heroName").val();
    $.ajax({
        url: "/Hero/HeroCreation",
        data: {
            HeroName: heroName,
            HeroFaction: faction,
            HeroRace: factionClasses,
            HeroClass: heroClass,
        },
        method: "POST",
        success: function (response) {
            if (response == true) {
                alert("You will now be redirected.");
                window.location = "/";
            }
        }
    })
})





//ItemCreation
let itemType = "";
let itemPrice = "";
let itemImageUrl = "";
let itemDescription = "";
let itemName = "";
let itemMaterial = "";

$(".ItemType").click(function () {
    itemType = $(this).val();
})


//$(".priceInput").click(function () {
//    itemPrice = $(this).val();
//})

//$(".urlInput").click(function () {
//    itemImageUrl = $(this).val();
//})
//$(".descriptionInput").click(function () {
//    itemDescription = $(this).val();
//})
//$(".itemNameInput").click(function () {
//    itemName = $(this).val();
//})
$(".ItemMaterial").click(function () {
    itemMaterial = $(this).val();
})

$("#submitItemCreation").click(function () {

    itemPrice = $(".priceInput").val();
    itemImageUrl = $(".urlInput").val();
    itemDescription = $(".descriptionInput").val();
    itemName = $(".itemNameInput").val();
    $.ajax({
        url: "/Administration/Administration/AddItem",
        data: {
            ItemName: itemName,
            Description: itemDescription,
            ImageUrl: itemImageUrl,
            Price: itemPrice,
            ArmorMaterial: itemMaterial,
            ItemSlots: itemType,
        },
        method: "POST",
        success: function (response) {
            if (response == true) {
                alert("You will now be redirected.");
                window.location = "/";
            }
        }
    })
})


$("#heroDelete").click(function () {
    heroToDelete = $("#heroDelete").val();
    $.ajax({
        url: "/UserHeroes/DeleteHero",
        data: {
            HeroName: heroToDelete.HeroName,
            HeroFaction: heroToDelete.HeroFaction,
            HeroRace: heroToDelete.HeroRace,
            HeroClass: heroToDelete.HeroClass,
        },
        method: "POST",
        success: function (response) {
            if (response == true) {
                alert("You will now be redirected.");
                window.location = "/";
            }
        }
    })
})
//$(document).ready(function () {
//    // Activate tooltip
//    $('[data-toggle="tooltip"]').tooltip();

//    // Select/Deselect checkboxes
//    var checkbox = $('table tbody input[type="checkbox"]');
//    $("#selectAll").click(function () {
//        if (this.checked) {
//            checkbox.each(function () {
//                this.checked = true;
//            });
//        } else {
//            checkbox.each(function () {
//                this.checked = false;
//            });
//        }
//    });
//    checkbox.click(function () {
//        if (!this.checked) {
//            $("#selectAll").prop("checked", false);
//        }
//    });
//});