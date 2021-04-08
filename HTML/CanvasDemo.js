
const canvas = document.getElementById('omaCanvas');
const ctx = canvas.getContext('2d');

// suorakaide
ctx.fillStyle = 'green';
ctx.fillRect(10, 10, 150, 100);

// ympyrä
ctx.beginPath();
ctx.arc(300, 275, 50, 0, 2 * Math.PI);
ctx.stroke();
