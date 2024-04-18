const passwordToggler = document.getElementById("togglePassword");

if (passwordToggler) {
    passwordToggler.addEventListener('click', function (e) {
        const password = document.getElementById('password');
        
        if (!password) return console.error('Password input not found');
        
        const type = password.getAttribute('type') === 'password' ? 'text' : 'password';
        password.setAttribute('type', type);

        const icon = document.getElementById('eyeIconPassword');
        
        if (!icon) return console.error('Password icon not found');
        
        icon.textContent = icon.textContent === 'visibility' ? 'visibility_off' : 'visibility';
    });
}


const confirmPasswordToggler = document.getElementById("toggleConfirmPassword");

if (confirmPasswordToggler) {
    confirmPasswordToggler.addEventListener('click', function (e) {
        const passwordConf = document.getElementById("confirmPassword");
        
        if (!passwordConf) return console.error('Confirm password input not found');
        
        const type = passwordConf.getAttribute('type') === 'password' ? 'text' : 'password';
        passwordConf.setAttribute('type', type);

        const icon = document.getElementById('eyeIconConfirmPassword');
        
        if (!icon) return console.error('Confirm password icon not found');
        
        icon.textContent = icon.textContent === 'visibility' ? 'visibility_off' : 'visibility';
    });
}