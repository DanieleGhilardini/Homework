vector<int> reverseArray(vector<int> a) {
    let temp1;
    let temp2;
    for (let i=0; i<(a.length/2); i++) {
        temp1 = a[i];
        temp2 = a[a.size()-(i+1)];
        a[i] = temp2;
        a[a.size()-(i+1)] = temp1;
    }
    return a;
}