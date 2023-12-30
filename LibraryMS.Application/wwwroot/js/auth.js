$('.togglePasswordIconBtn').click(() => {
    $('.passwordInput').attr('type', () => {
        if ($('.passwordInput').attr('type') == 'password')
            $('.passwordInput').attr('type', 'text');
        else
            $('.passwordInput').attr('type', 'password');
    });
})
