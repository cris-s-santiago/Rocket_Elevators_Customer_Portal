function UpdateCustomer() {

    var data = {
        company_name: $('#company_name').val(),
        cpy_contact_full_name: $('#cpy_contact_full_name').val(),
        cpy_contact_phone: $('#cpy_contact_phone').val(),
        cpy_contact_email: $('#cpy_contact_email').val(),
        cpy_description: $('#cpy_description').val(),
        tech_authority_service_full_name: $('#tech_authority_service_full_name').val(),
        tech_authority_service_phone: $('#tech_authority_service_phone').val(),
        tech_manager_service_email: $('#tech_manager_service_email').val()
    };

    $.ajax({
        url: 'https://rocketelevatorrestapi.azurewebsites.net/api/Customers',
        type: 'PUT',
        data: JSON.stringify(data),
        headers: {
            "Access-Control-Allow-Origin": "*",
            "Access-Control-Allow-Methods": "HEAD, GET, POST, PUT, PATCH, DELETE",
            "Access-Control-Allow-Headers": "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With",
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        success: function (result) {
            alert('Customer updated successfully!');
            return false;
        }
    });

    return false;
}