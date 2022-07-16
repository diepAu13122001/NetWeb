let amount = 1;
let countid = document.getElementById("count")
countid.innerHTML = `${amount.toString()}`

let countid1 = document.getElementById("count1")
countid1.innerHTML = `${amount.toString()}`

let countid2 = document.getElementById("count2")
countid2.innerHTML = `${amount.toString()}`
function minius() {
  if (amount > 0) {
    amount = amount - 1;
    console.log("amount1", amount)
    countid.innerHTML = `${amount.toString()}`
  } else {
    amount = 0;
    countid.innerHTML = `${amount.toString()}`
  }
}

function add() {
  amount = amount + 1;
  console.log("amount2", amount)
  countid.innerHTML = `${amount.toString()}`

}
