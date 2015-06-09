$(function () {
    var message_dialog = "<div id=\"message_dialog\" style=\"display:none;\">";
    message_dialog += "<div class=\"dialog_content_panel\"><span class=\"dialog_message\"></span></div>";
    message_dialog += "<div class=\"dialog_button_panel\"><button class=\"dialog_button\"><span class=\"ok_button\"></span><span>确定(<span class=\"timeout_number\">3</span>)</span></button></div>";
    message_dialog += "</div>";
    var confirm_dialog = "<div id=\"confirm_dialog\" style=\"display:none;\">";
    confirm_dialog += "<div class=\"dialog_content_panel question_icon\"><span class=\"dialog_message\"></span></div></span>";
    confirm_dialog += "<div class=\"dialog_button_panel\">";
    confirm_dialog += "<button class=\"dialog_button\"><span class=\"yes_button\"></span>确定</button>";
    confirm_dialog += "<button class=\"dialog_button not_first_button\"><span class=\"no_button\"></span>取消</button>";
    confirm_dialog += "</div>";
    confirm_dialog += "</div>";
    $("body").append(message_dialog).append(confirm_dialog);
    var messageDialogTitle = '';
    if (window["messageDialogTitle"] != null)
    {
        messageDialogTitle = window["messageDialogTitle"];
    }
    $("#message_dialog").dialog({
        autoOpen: false,
        title: messageDialogTitle,
        closeText: "关闭",
        modal: true,
        resizable: false,
        width: 260,
        height: 150,
        create: function (event, ui) {
            $("div#message_dialog .dialog_button").button();
        },
        open: function (event, ui) {
            $("div#message_dialog").parent().css("z-index", "10001");
            $("div.ui-widget-overlay:last").css("z-index", "10000");
            $("div#message_dialog .dialog_button").focus();
        }
    });
    $("#confirm_dialog").dialog({
        autoOpen: false,
        title: messageDialogTitle,
        closeText: "关闭",
        modal: true,
        resizable: false,
        width: 260,
        height: 150,
        create: function (event, ui) {
            $("div#confirm_dialog .dialog_button").button();
            $($("div#confirm_dialog .dialog_button")[1]).bind("click", function () {
                $("#confirm_dialog").dialog("close");
            });
        },
        open: function (event, ui) {
            $("div.ui-widget-overlay:last").css("z-index", "20000");
            $("div#confirm_dialog").parent().css("z-index", "20001");
        }
    });
});

var DefaultFouceButton = {
    "YesButton" : 0,
    "NoButton" : 1,
    "CancelButton": -1
};
var MessageIconType = {
    "Question": "question",
    "Info" : "info",
    "Error": "error",
    "Warning": "warning"
};

//message,ok_button_function,icon-type,focus_index
function showConfirmDialog(options) {
    var setting = {
        Message: "",
        Type: MessageIconType.Question,
        Focus: DefaultFouceButton.NoButton,
        YesCallback: function () {
        },
        NoCallback: function () { 
        }
    };
    jQuery.extend(setting, options);

    var type = MessageIconType.Question;
    if (typeof (setting["Type"]) == "string" && setting["Type"] != "") {
        type = setting["Type"];
    }

    var message = "";
    if (typeof (setting["Message"]) == "string") {
        message = setting["Message"];
    }

    if (typeof (setting["YesCallback"]) == "function") {
        var yesButtonClickFunction = setting["YesCallback"];
        $($("div#confirm_dialog .dialog_button")[0]).unbind("click").bind("click", function () {
            $("#confirm_dialog").dialog("close");
            yesButtonClickFunction();
        });
    }

    if (typeof (setting["NoCallback"]) == "function") {
        var noButtonClickFunction = setting["NoCallback"];
        $($("div#confirm_dialog .dialog_button")[1]).unbind("click").bind("click", function () {
            $("#confirm_dialog").dialog("close");
            noButtonClickFunction(); 
        });
    }

    var focusButtonIndex = 1;
    if (typeof (setting["Focus"]) == "number") {
        focusButtonIndex = setting["Focus"];
    }

    $("div#confirm_dialog span.dialog_message").html(message);
    $("div#confirm_dialog div.dialog_content_panel").attr("class", "dialog_content_panel " + type + "_icon");
    $("#confirm_dialog").dialog("open");
    if (focusButtonIndex == -1) {
        $($("div#confirm_dialog").parent().find("button.ui-dialog-titlebar-close")[0]).focus();
    } else {
        $($("div#confirm_dialog .dialog_button")[focusButtonIndex]).focus();
    }
}

//显示消息对话框的方法
function showMessageDialog(options) {
    var setting = {
        Message: "",
        Type: MessageIconType.Info,
        Callback: function () { 
        }
    };
    jQuery.extend(setting, options);

    var type = MessageIconType.Info;
    if (typeof (setting["Type"]) == "string" && setting["Type"] != "") {
        type = setting["Type"];
    }

    var message = "";
    if (typeof (setting["Message"]) == "string") {
        message = setting["Message"];
    }
    
    $("div#message_dialog div.dialog_content_panel").attr("class", "dialog_content_panel " + type + "_icon");
    $("div#message_dialog span.dialog_message").html(message);
    $("#message_dialog .timeout_number").html("3");
    $("div#message_dialog button.dialog_button").bind("click", function () {
        $("#message_dialog").dialog("close");
        if (typeof (setting["Callback"]) == "function") {
            setting["Callback"]();
        }
        setting["Callback"] = null;
    }).bind("keydown", function (event) {
        if (event.keyCode == 13) {
            return false;
        }
    }).bind("keyup", function (event) {
        if (event.keyCode == 13) {
            $("#message_dialog").dialog("close");
            if (typeof (setting["Callback"]) == "function") {
                setting["Callback"]();
            }
            setting["Callback"] = null;
        }
    });
    $("#message_dialog").on("dialogclose", function (event, ui) {
        window.clearTimeout(window.dialog_mssage_timeout);
        if (typeof (setting["Callback"]) == "function") {
            setting["Callback"]();
        }
        setting["Callback"] = null;
    }).dialog("open");
    var dialog_mssage_timeout_function = function () {
        var timeoutNumber = parseInt($("#message_dialog .timeout_number").html()) - 1;
        if (timeoutNumber == 0) {
            window.clearTimeout(window.dialog_mssage_timeout);
            $("#message_dialog").dialog("close");
            if (typeof (setting["Callback"]) == "function") {
                setting["Callback"]();
            }
            setting["Callback"] = null;
        } else {
            $("#message_dialog .timeout_number").html(timeoutNumber);
            window.dialog_mssage_timeout = setTimeout(dialog_mssage_timeout_function, 1000);
        }
    };
    window.dialog_mssage_timeout = setTimeout(dialog_mssage_timeout_function, 1000);
}

function isMessageDialogShow() {
    return $("#message_dialog").dialog("option", "show");
}