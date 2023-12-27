// move = (e)=>{

//     block.style.left = e.pageX + "px"
//     block.style.top = e.pageY + "px"

// }


let posX = null;
let posY = null;
let timeoutId = null;

document.addEventListener('mousedown', (event) => {
    posX = block.offsetLeft;
    posY = block.offsetTop;
    clearTimeout(timeoutId);

    function moveBlock() {
      const dx = event.clientX - posX;
      const dy = event.clientY - posY;
      const vx = dx / 10;
      const vy = dy / 10;

      posX += vx;
      posY += vy;

      block.style.left = `${posX}px`;
      block.style.top = `${posY}px`;

      timeoutId = setTimeout(moveBlock, 16);
    }

    moveBlock();
});
