const cartItems = document.querySelectorAll('.cart-steps-three-item-input')

cartItems.forEach((item) => {
    item.addEventListener('click', () => {
       cartItems.forEach(i => i.checked = false)

       item.checked = true
    })
})