   // search-box open close js code
   let menu = document.querySelector(".menu"); 
   // menu responsivo para celular, abrir e fechar
    let opcoes = document.querySelector(".opcoes");
    let menuOpenBtn = document.querySelector(".menu i.fa-bars");
    let menuCloseBtn = document.querySelector(".opcoes i.bx-x");
    menuOpenBtn.onclick = function() {
    opcoes.style.left = "0";
    }
    menuCloseBtn.onclick = function() {
      opcoes.style.left = "-100%";
    }
    
    
    // submenu responsivo para celular, abrir e fechar
    let  tiposArrow = document.querySelector(".tipos-arrow");
    tiposArrow.onclick = function() {
      opcoes.classList.toggle("show1");
    }
    let produtoArrow = document.querySelector(".produto-arrow");
    produtoArrow.onclick = function() {
      opcoes.classList.toggle("show2");
    }
    let idiomaArrow = document.querySelector(".idioma-arrow");
    idiomaArrow.onclick = function() {
      opcoes.classList.toggle("show3");
    }
  
  
  