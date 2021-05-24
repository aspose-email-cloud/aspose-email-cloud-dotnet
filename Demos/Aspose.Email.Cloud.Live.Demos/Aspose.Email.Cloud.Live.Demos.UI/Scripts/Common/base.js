// filedrop component
var fileDrop = {};

function showLoader() {
	$('.progress > .progress-bar').html('15%');
	$('.progress > .progress-bar').css('width', '15%');
	$('#loader').removeClass("hidden");
	hideAlert();
}

function hideLoader() {
	$('#loader').addClass("hidden");
}

function workSuccess(data, textStatus, xhr) {
	hideLoader();
	var response = data.split('|');
	if (response.length > 0) {
		var statusCode = response[0];
		var fileName = response[1];

		if (statusCode === '200') {

			$('#WorkPlaceHolder').addClass('hidden');
			$('#DownloadPlaceHolder').removeClass('hidden');

			var url = encodeURI(o.UIBasePath + `common/download?file=${fileName}`);

			$('#DownloadButton').attr('href', url);
		} else {
			showAlert(statusCode);
		}
	}
}

function hideAlert() {
	$('#alertMessage').addClass("hidden");
	$('#alertMessage').text("");
	$('#alertSuccess').addClass("hidden");
	$('#alertSuccess').text("");
}

function showAlert(msg) {
	hideLoader();
	$('#alertMessage').html(msg);
	$('#alertMessage').removeClass("hidden");
	$('#alertMessage').fadeOut(100).fadeIn(100).fadeOut(100).fadeIn(100);
}

function showMessage(msg) {
	hideLoader();
	$('#alertSuccess').text(msg);
	$('#alertSuccess').removeClass("hidden");
}

function progress(evt) {
	if (evt.lengthComputable) {
		var max = evt.total;
		var current = evt.loaded;

		var percentage = Math.round((current * 100) / max);
		percentage = (percentage < 15 ? 15 : percentage) + '%';

		$('.progress > .progress-bar').html(percentage);
		$('.progress > .progress-bar').css('width', percentage);
	}
}

function removeAllFileBlocks() {
	fileDrop.droppedFiles.forEach(function (item) {
		$('#fileupload-' + item.id).remove();
	});
	fileDrop.droppedFiles = [];
	hideLoader();
}

function request(url, data) {
	showLoader();
	$.ajax({
		type: 'POST',
		url: url,
		data: data,
		cache: false,
		contentType: false,
		processData: false,
		success: workSuccess,
		xhr: function () {
			var myXhr = $.ajaxSettings.xhr();
			if (myXhr.upload)
				myXhr.upload.addEventListener('progress', progress, false);
			return myXhr;
		},
		error: function (err) {
			if (err.data !== undefined && err.data.Status !== undefined)
				showAlert(err.data.Status);
			else
				showAlert("Error " + err.status + ": " + err.statusText);
		}
	});
}

function requestConversion() {
	let data = fileDrop.prepareFormData();
	if (data === null)
		return;

	let url = o.UIBasePath + 'Conversion/Conversion?outputType=' + $('#saveAs').val().trim().toLowerCase();

	request(url, data);
}

$(document).ready(function () {

	fileDrop = $('form#UploadFile').filedrop(Object.assign({
		showAlert: showAlert,
		hideAlert: hideAlert,
		showLoader: showLoader,
		progress: progress
	}, o));

	if (!o.UploadAndRedirect) {
		$('#uploadButton').on('click', o.Method);
	}
});
