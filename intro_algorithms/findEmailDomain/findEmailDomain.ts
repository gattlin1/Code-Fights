function findEmailDomain(address: string): string {
    const arr = address.split('@');
    return arr[arr.length - 1];
}
