public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        // Dicionário para armazenar a primeira ocorrência de cada resto
        Dictionary<int, int> IndiceResto = new Dictionary<int, int>();
        IndiceResto[0] = -1; // Inicializa com o resto 0 no índice -1 para cuidar do subvetor que começa no index 0.
        int somaAtual = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            somaAtual += nums[i];
            //Pega o resto da soma atual.
            somaAtual %= k;
        
            if (IndiceResto.ContainsKey(somaAtual)) {
                // Garante que o comprimento do vetor é maior ou igual a 2. Se o resto já existir é pq a soma de dois ou mais valores é multiplo de k
                if (i - IndiceResto[somaAtual] > 1) {
                    return true;
                }
            } else {
                // Guarda o resto quando ele é novo no dicionário.
                IndiceResto[somaAtual] = i;
            }
        }
        
        return false;
    }
}
