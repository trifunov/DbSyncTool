﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$("#syncEmployees").click(function () {
    $.ajax({
        url: "/api/Sync/SyncEmployees", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncAccounts").click(function () {
    $.ajax({
        url: "/api/Sync/SyncAccounts", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncSites").click(function () {
    $.ajax({
        url: "/api/Sync/SyncSites", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncEvents").click(function () {
    $.ajax({
        url: "/api/Sync/SyncEvents", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncPortalLogins").click(function () {
    $.ajax({
        url: "/api/Sync/SyncPortalLogins", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncWos").click(function () {
    $.ajax({
        url: "/api/Sync/SyncWos", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncInspectionPointCategory").click(function () {
    $.ajax({
        url: "/api/Sync/SyncInspectionPointCategory", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncInspectionPointTypes").click(function () {
    $.ajax({
        url: "/api/Sync/SyncInspectionPointTypes", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncInspectionPoints").click(function () {
    $.ajax({
        url: "/api/Sync/SyncInspectionPoints", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncEventsSold").click(function () {
    $.ajax({
        url: "/api/Sync/SyncEventsSold", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncEventsPattern").click(function () {
    $.ajax({
        url: "/api/Sync/SyncEventsPattern", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncMaterialsSetup").click(function () {
    $.ajax({
        url: "/api/Sync/SyncMaterialsSetup", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncMaterials").click(function () {
    $.ajax({
        url: "/api/Sync/SyncMaterials", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncInspectionPointHistory").click(function () {
    $.ajax({
        url: "/api/Sync/SyncInspectionPointHistory", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#syncTargetPest").click(function () {
    $.ajax({
        url: "/api/Sync/syncTargetPest", success: function (result) {
            fadeSuccess(result);
            setButtonsByStatus();
        }
    });
});

$("#initDb").click(function () {
    $.ajax({
        url: "/api/Sync/InitDb", success: function (result) {
            fadeSuccess(result);
        }
    });
});

$(function () {
    setButtonsByStatus();
});

function setButtonsByStatus() {
    $.ajax({
        url: "/api/Sync/GetSyncStatus", success: function (result) {
            $(".button-sync").each(function (i, e) {
                if (i < result) {
                    $(this).prop("disabled", true);
                    $(this).addClass("btn-disabled");
                }
            });
        }
    });
}

function fadeSuccess(message) {
    $("#successMessage").text(message);
    $("#successMessage").fadeIn("slow", function () {
        setTimeout(function () {
            $('#successMessage').fadeOut("slow");
        }, 2000);
    });
}