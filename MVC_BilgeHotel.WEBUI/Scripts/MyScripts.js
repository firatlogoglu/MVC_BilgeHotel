function DatePicker() {
    $('datepicker').datepicker({
        dateFormat: 'dd-M-yy',
        changeMonth: true,
        changeYear: true,
        showOn: 'button',
        sideBySide: true,
        controlType: 'select',
        buttonText: '<span class="glyphicon-calender"></span>',
        minDate: new Date()
    });
}