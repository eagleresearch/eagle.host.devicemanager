$(function () {   
    var l = abp.localization.getResource("DeviceManager");
	
	var deviceService = window.eagle.host.deviceManager.devices.device;
	
		
    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Devices/CreateModal",
        scriptUrl: "/Pages/Devices/createModal.js",
        modalClass: "deviceCreate"
    });

	var editModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Devices/EditModal",
        scriptUrl: "/Pages/Devices/editModal.js",
        modalClass: "deviceEdit"
    });

	var getFilter = function() {
        return {
            filterText: $("#FilterText").val(),	
            numberMin: $("#NumberFilterMin").val(),
			numberMax: $("#NumberFilterMax").val(),
			name: $("#NameFilter").val()
        };
    };
	
    var dataTable = $("#DevicesTable").DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        scrollX: true,
        autoWidth: false,
        scrollCollapse: true,
        order: [[2, "asc"]],
        ajax: abp.libs.datatables.createAjax(deviceService.getList, getFilter),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l("Edit"),
                                visible: abp.auth.isGranted('DeviceManager.Devices.Edit'),
                                action: function (data) {                                     
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l("Delete"),
                                visible: abp.auth.isGranted('DeviceManager.Devices.Delete'),
                                confirmMessage: function () {
                                    return l("DeleteConfirmationMessage");
                                },
                                action: function (data) {                                        
                                    deviceService.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l("SuccessfullyDeleted"));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
			{ data: "number" }
,			{ data: "name" }

            
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $("#NewDeviceButton").click(function (e) {        
        e.preventDefault();        
        createModal.open();
    });

	$("#SearchButton").click(function (e) {
        e.preventDefault();
        dataTable.ajax.reload();
    });

    $('#FilterText').keypress(function (e) {
        if (e.which === 13) {
            dataTable.ajax.reload();
        }
    });
	
    $('#AdvancedFilterSectionToggler').on('click', function (e) {
        $('#AdvancedFilterSection').toggle();
    });

    $('#AdvancedFilterSection').on('keypress', function (e) {
        if (e.which === 13) {
            dataTable.ajax.reload();
        }
    });

    $('#AdvancedFilterSection select').change(function() {
        dataTable.ajax.reload();
    });
});