function GetCreateModal(val) {
    var url = $(val).data("url");

}
function CreateElement(url, object) {
    $.ajax({
        type: "GET",
        url: "/App" + url,
        dataType: "html",
        success: function (data) {
            $("#create-modal").find(".panel-body").html(data);          
            document.getElementById("CreateModalHeader").innerHTML = "KRIJO " + object;
            $("#create-modal").modal('show');
        }
    });
}
