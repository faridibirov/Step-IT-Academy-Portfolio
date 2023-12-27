green.addEventListener("mouseenter", 
(e)=> {
    box.style.background = "green";
}
)

yellow.addEventListener("mouseenter", 
(e)=> {
    box.style.background = "yellow";
}
)

pink.addEventListener("mouseenter", 
(e)=> {
    box.style.background = "pink";
}
)


green.onmouseleave = yellow.onmouseleave = pink.onmouseleave = () => {

    box.style.background = "grey";
}




