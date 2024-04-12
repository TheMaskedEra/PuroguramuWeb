function loadFile(event) {
    const input = event.target;
    const file = input.files[0];
    const type = file.type;

    const output = document.getElementById('preview_img');

    output.src = URL.createObjectURL(event.target.files[0]);
    output.onload = function() {
        URL.revokeObjectURL(output.src)
    }
}