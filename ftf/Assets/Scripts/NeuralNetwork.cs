using System.Collections.Generic;
using System;

public class NeuralNetwork : IComparable<NeuralNetwork>
{
    private int[] layers;
    private float[][] neurons;
    private float[][][] weights;
    private float fitness;


    public NeuralNetwork(int[] layers)
    {
        this.layers = new int[layers.Length];
        for (int i=0; i<layers.Length; i++)
        {
            this.layers[i] = layers[i];
        }
        InitNeurons();
        InitWeights();
    }


    public NeuralNetwork(NeuralNetwork copyNetwork)
    {
        this.layers = new int[copyNetwork.layers.Length];
        for(int i=0; i<copyNetwork.layers.Length; i++)
        {
            this.layers[i] = copyNetwork.layers[i];
        }
        InitNeurons();
        InitWeights();
        CopyWeights(copyNetwork.weights);

    }

    private void CopyWeights(float[][][] copyweights)
    {
        for (int i = 0; i < weights.Length; i++)
        {
            for (int j = 0; j < weights[i].Length; j++)
            {
                for (int k = 0; k < weights[i][j].Length; k++)
                {
                    weights[i][j][k] = copyweights[i][j][k];
                }
            }
        }
    }


    private void InitNeurons()
    {
        List<float[]> neuronsList = new List<float[]>();

        for(int i=0; i<layers.Length; i++)
        {
            neuronsList.Add(new float[layers[i]]);
        }
        neurons = neuronsList.ToArray();
    }

    private void InitWeights()
    {
        List<float[][]> WeightsList = new List<float[][]>();

        for (int i = 1; i < layers.Length; i++)
        {
            List<float[]> layerWeightList = new List<float[]>();
            int neuronsInPreviousLayer = layers[i - 1];

            for(int j=0; j< neurons[i].Length; j++)
            {
                float[] neuronWeights = new float[neuronsInPreviousLayer];

                for(int k=0; k< neuronsInPreviousLayer; k++)
                {
                    //give random weights to neuron weights
                    neuronWeights[k] = UnityEngine.Random.Range(-0.5f,0.5f);
                }

                layerWeightList.Add(neuronWeights);
            }

            WeightsList.Add(layerWeightList.ToArray());

        }
        weights = WeightsList.ToArray();

    }

    public float[] FeedForeward(float[] inputs)
    {
        for(int i=0; i<inputs.Length; i++)
        {
            neurons[0][i] = inputs[i];
        }
        for(int i=1; i<layers.Length; i++)
        {
            for(int j=0; j<neurons[i].Length; j++)
            {
                float value = 0.25f;
                for(int k=0; k<neurons[i-1].Length; k++)
                {
                    value += weights[i - 1][j][k] * neurons[i - 1][k];
                }
                neurons[i][j] = (float)Math.Tanh(value);
            }
        }


        return neurons[neurons.Length-1];
    }

    public void Mutate()
    {
        for(int i=0; i<weights.Length; i++)
        {
            for(int j=0; j<weights[i].Length; j++)
            {
                for(int k=0; k<weights[i][j].Length; k++)
                {
                    float weight = weights[i][j][k];
                    float randomNumber = UnityEngine.Random.Range(1f, 10f);
                    if(randomNumber <= 2f)
                    {
                        weight *= -1f;
                    }
                    else if (randomNumber <= 4f)
                    {
                        weight = UnityEngine.Random.Range(-0.5f, 0.5f);
                    }
                    else if (randomNumber <= 6f)
                    {
                        float factor = UnityEngine.Random.Range(0f,1f)+1f;
                        weight *= factor;
                    }
                    else if (randomNumber <= 8f)
                    {
                        float factor = UnityEngine.Random.Range(0f,1f);
                        weight *= factor;
                    }




                    weights[i][j][k] = weight;
                }
            }
        }
    }
    public void AddFitness(float fit)
    {
        fitness += fit;
    }
    public void SetFitness(float fit)
    {
        fitness = fit;
    }
    public float GetFitness()
    {
        return fitness;
    }

    public int CompareTo(NeuralNetwork other)
    {
        if (other == null) return 1;
        if (fitness > other.fitness)
            return 1;
        else if (fitness < other.fitness)
            return -1;
        else
            return 0;
    }




}
