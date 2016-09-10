$.validator.addMethod("date", function (value, element) {
    var check = false;
    var short = /^\d{1,2}\/\d{1,2}\/\d{4}$/;
    var long = /^\d{1,2}\/\d{1,2}\/\d{4} \d{2}:\d{2}:\d{2} \w{2}$/;
    var special = /^\d{1,2} tháng \d{1,2} năm \d{4}$/;
    if (short.test(value) || long.test(value) || special.test(value)) {
        value = value.replace(" tháng ", "/");
        value = value.replace(" năm ", "/");
        var adata = value.split('/');
        var dd = parseInt(adata[0], 10);
        var mm = parseInt(adata[1], 10);
        var yyyy = parseInt(adata[2].split(' ')[0], 10);
        var xdata = new Date(yyyy, mm - 1, dd);
        if ((xdata.getFullYear() == yyyy) && (xdata.getMonth() == mm - 1) && (xdata.getDate() == dd))
            check = true;
        else check = false;
    } else check = false;
    return this.optional(element) || check;
});

function Editor_Add(elem, rand) {
    var partial = $("#" + rand);
    partial.block({ message: "Loading..." });
    partial.load(elem.href, function (response, status, xhr) {
        partial.html(response);
        partial.unblock();
        partial.find("form").submit(function () {
            partial.block({ message: "Processing..." });
            $(this).ajaxSubmit({ success: function (responseText, statusText, xhr, $form) {
                if (responseText.length > 0) {
                    alert(responseText);
                    partial.unblock();
                } else {
                    location.reload();
                    partial.block({ message: "Loading..." });
                }
            }
            });
            return false;
        });
        partial.find("a.close").click(function () {
            partial.html("");
            return false;
        });
    });
    return false;
}

function Editor_Edit(elem, add) {
    (elem = $(elem)).parents("table").find("tr").each(function () {
        var tr = $(this).removeClass("row_selected");
        if (tr.find(".editor").length > 0) tr.remove();
    });
    var tr = elem.parents("tr").addClass("row_selected");
    var partial = $("<td></td>").attr("colspan", tr.find("td,th").length).addClass("editor");
    if (add != true) tr.after($("<tr></tr>").append(partial));
    else elem.parents("table").find("tbody").first().prepend($("<tr></tr>").append(partial));
    partial.block({ message: "Loading..." });
    partial.load(elem.attr("href"), function (response, status, xhr) {
        partial.html(response);
        partial.unblock();
        partial.find("form").submit(function () {
            partial.block({ message: "Processing..." });
            $(this).ajaxSubmit({ success: function (responseText, statusText, xhr, $form) {
                if (responseText.length > 0) {
                    alert(responseText);
                    partial.unblock();
                } else {
                    location.reload();
                    partial.block({ message: "Loading..." });
                }
            }
            });
            return false;
        });
        partial.find("a.close").click(function () {
            $(this).parents("tr").remove();
            return false;
        });
    });
    return false;
}

function Editor_Action(elem, load) {
    var tr = (elem = $(elem)).parents("tr");
    tr.block({ message: "Processing..." });
    elem.ajaxSubmit({ url: $(elem).attr("href"), type: "post",
        success: function (responseText, statusText, xhr, $form) {
            if (responseText.length > 0) {
                alert(responseText);
                if (load == true)
                    location.reload();
            } else location.reload();
            tr.unblock();
        }
    });
    return false;
}

function Editor_Delete(elem) {
    var tr = (elem = $(elem)).parents("tr");
    if (confirm("Do you want to delete this?")) {
        tr.block({ message: "Processing..." });
        elem.ajaxSubmit({ url: $(elem).attr("href"), type: "post",
            success: function (responseText, statusText, xhr, $form) {
                if (responseText.length > 0)
                    alert(responseText);
                else location.reload();
                tr.unblock();
            }
        });
    }
    return false;
}

function Message_Edit(link, table, callback) {
    $(link).parents("table").add($(table)).find("tr").each(function () {
        var tr = $(this).removeClass("row_selected");
        if (tr.find(".editor").length > 0) tr.remove();
    });
    var tr = $(link).parents("tr").addClass("row_selected");
    var partial = $('<td colspan="100%"></td>').addClass("editor");
    if (table == undefined) tr.after($("<tr></tr>").append(partial));
    else $(table).find("tbody").first().prepend($("<tr></tr>").append(partial));
    partial.block({ message: "Loading..." });
    partial.load(link.attr("href"), function (response, status, xhr) {
        partial.html(response);
        partial.unblock();
        partial.find("form").submit(function () {
            partial.block({ message: "Processing..." });
            $(this).ajaxSubmit({ success: function (responseText, statusText, xhr, $form) {
                if (responseText.length > 0) {
                    alert(responseText);
                    partial.unblock();
                } else {
                    partial.block({ message: "Loading..." });
                    callback();
                }
            }
            });
            return false;
        });
        partial.find("a.close").click(function () {
            $(this).parents("tr").remove();
            return false;
        });
    });
    return false;
}
