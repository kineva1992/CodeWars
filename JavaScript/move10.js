function moveTen(s) {
    moveten = [];
    let arr = s.split("").map((word) => word.charCodeAt());
    for (i = 0; i < arr.length; i++) {
      move = arr[i] + 10;
      if (move > 122) {
        move = move - 26;
        moveten.push(move);
      } else {
        moveten.push(move);
      }
    }
    text = moveten.map((word) => String.fromCharCode(word)).join("");
    return text;
  }