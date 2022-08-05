function Confirm(vMsg) {
    Swal.fire({
        title: '¿Confirmación?',
        text: vMsg,
        icon: 'warning',
        showCancelButton: true,
        cancelButtonColor: '#d33'
    }).then((result) => {
        if (result.isConfirmed) {
            Swal.fire(
                'Eliminado!',
                'Su archivo ha sido eliminado.',
                'success'
            )
        }
    })
}
