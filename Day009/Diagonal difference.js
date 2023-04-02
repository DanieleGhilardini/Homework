function diagonalDifference(arr) {
  let firstD = 0;
  let secondD = 0;
  for (let i = 0; i < arr.length; i++) {
    firstD += arr[i][i];
  }
  for (let j = arr.length - 1; j >= 0; j--) {
    secondD += arr[j][arr.length - j - 1];
  }
  let sol = firstD - secondD;
  if (sol >= 0) {
    return sol;
  } else {
    sol -= 2 * sol;
    return sol;
  }
}
