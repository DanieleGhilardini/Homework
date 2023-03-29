function hourglassSum(arr) {
  let max = Number.MIN_VALUE;
  for (let i = 0; i < arr.length - 2; i++) {
    for (let j = 0; j < arr.length - 2; j++) {
      let value =
        arr[i][j] +
        arr[i][j + 1] +
        arr[i][j + 2] +
        arr[i + 1][j + 1] +
        arr[i + 2][j] +
        arr[i + 2][j + 1] +
        arr[i + 2][j + 2];
      if (max == Number.MIN_VALUE || max < value) {
        max = value;
      }
    }
  }
  return max;
}
