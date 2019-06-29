#include <bits/stdc++.h>
#define REP(i, n) for(int i = 0; i < n; i++)
#define REPP(i, n) for(int i = 1; i <= n; i++)
#define REPR(i, n) for(int i = n; i >= 0; i--)
#define FOR(i, m, n) for(int i = m; i < n; i++)
#define ALL(v) v.begin(), v.end()
#define UNIQUE(v) v.erase(unique(v.begin(), v.end()), v.end());
using namespace std;
typedef long long ll;
typedef pair<ll, ll> p;
const ll MOD = 1000000007;

bool binarySearch(int key, vector<int> v, int n) {
    int left = 0;
    int right = n;
    int mid;
    bool ans = false;
    while (left<right) {
        mid = (left + right)/2;
        if(v[mid]==key) {
            ans = true;
            break;
        }
        mid = (key < v[mid] ? right = mid : left = mid+1);
    }
    return ans;
}

int main() {
    ifstream in("input.txt");
    cin.rdbuf(in.rdbuf());
    int n; cin >> n;
    vector<int> s(n);
    REP(i,n) cin >> s[i];
    int q; cin >> q;
    vector<int> t(q);
    REP(i,q) cin >> t[i];
    int ans = 0;
    REP(i,q) {
        ans += (binarySearch(t[i], s, n));
    }
    cout << ans << endl;
    return 0;
}