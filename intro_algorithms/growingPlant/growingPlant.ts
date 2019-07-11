function growingPlant(upSpeed: number, downSpeed: number, desiredHeight: number): number {
    if(upSpeed >= desiredHeight) {
        return 1;
    }
    else{
        return Math.ceil((desiredHeight - downSpeed) / (upSpeed - downSpeed));
    }
}
