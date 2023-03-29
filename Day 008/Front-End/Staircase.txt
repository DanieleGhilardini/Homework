function staircase(n) {
    for(let i=0; i<n; i++){
        let line = "";
        for(let j=0; j<(n-1-i); j++) {
            line += " ";
        }
        for(let k=0; k<(i+1); k++) {
            line += "#";
        }
        console.log(line);
    }
}